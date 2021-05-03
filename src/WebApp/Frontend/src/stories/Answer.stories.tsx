import { Meta, Story } from "@storybook/react/types-6-0";
import Answer from "../components/Answer";
import StoryRouter from 'storybook-react-router';

export default {
    title: "components/Answer",
    decorators: [StoryRouter()],
    components: Answer,
} as Meta;

const Template: Story = () => <Answer />;

export const Default = Template.bind({});