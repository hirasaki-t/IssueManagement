import { Meta, Story } from "@storybook/react/types-6-0";
import AddProject from "../components/AddProject";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/AddProject",
    decorators: [StoryRouter()],
    components: AddProject,
} as Meta;

const Template: Story = () => <AddProject />;

export const Default = Template.bind({});