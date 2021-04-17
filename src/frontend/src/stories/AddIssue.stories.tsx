import { Meta, Story } from "@storybook/react/types-6-0";
import AddIssue from "../components/AddIssue";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/AddIssue",
    decorators: [StoryRouter()],
    components: AddIssue,
} as Meta;

const Template: Story = () => <AddIssue />;

export const Default = Template.bind({});